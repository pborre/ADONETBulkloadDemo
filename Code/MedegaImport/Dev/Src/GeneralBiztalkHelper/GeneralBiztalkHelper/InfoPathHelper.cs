using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace GeneralBiztalkHelper
{
    [Serializable]
    public class InfoPathAttachmentDecoder
    {
        #region Constats
        private const int SP1Header_Size = 20;
        private const int FIXED_HEADER = 16;
        #endregion

        #region Fields
        private int fileSize;
        private int attachmentNameLength;
        private string attachmentName;
        private byte[] decodedAttachment;
        #endregion

        #region Constructor
        /// <summary>
        /// Accepts the Base64 encoded string
        /// that is the attachment.
        /// </summary>
        public InfoPathAttachmentDecoder(string theBase64EncodedString)
        {
            byte[] theData = Convert.FromBase64String(theBase64EncodedString);
            using (MemoryStream ms = new MemoryStream(theData))
            {
                BinaryReader theReader = new BinaryReader(ms);
                DecodeAttachment(theReader);
            }
        }
        #endregion

        #region Private Methods
        private void DecodeAttachment(BinaryReader theReader)
        {
            //Position the reader to get the file size.
            byte[] headerData = new byte[FIXED_HEADER];
            headerData = theReader.ReadBytes(headerData.Length);

            fileSize = (int)theReader.ReadUInt32();
            attachmentNameLength = (int)theReader.ReadUInt32() * 2;

            byte[] fileNameBytes = theReader.ReadBytes(attachmentNameLength);
            //InfoPath uses UTF8 encoding.
            Encoding enc = Encoding.Unicode;
            attachmentName = enc.GetString(fileNameBytes, 0, attachmentNameLength - 2);
            decodedAttachment = theReader.ReadBytes(fileSize);

            
        }
        #endregion

        #region Public Methods
        public void SaveAttachment(string saveLocation)
        {
            string fullFileName = saveLocation;
            if (!fullFileName.EndsWith(Path.DirectorySeparatorChar.ToString()))
                fullFileName += Path.DirectorySeparatorChar;

            fullFileName += attachmentName;

            if (File.Exists(fullFileName))
                File.Delete(fullFileName);

            FileStream fs = new FileStream(fullFileName, FileMode.CreateNew);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(decodedAttachment);
            
            bw.Close();
            fs.Close();
        }
        #endregion

        #region Properties
        public string Filename
        {
            get { return attachmentName; }
        }

        public string DecodedAttachment
        {
            get { return Convert.ToBase64String(decodedAttachment); }
        }
        #endregion

        
    }	
}
