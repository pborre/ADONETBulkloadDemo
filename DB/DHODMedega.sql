USE [DHODMedega]
GO
/****** Object:  Table [dbo].[MedegaFile]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedegaFile](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](255) NOT NULL,
	[ReceivedOn] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
	[ProcessTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuardMetadata]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuardMetadata](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NOT NULL,
	[Modified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayConstraint]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayConstraint](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[RizivNumber] [nvarchar](11) NOT NULL,
	[AccountNumberValue] [nvarchar](16) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[StopDate] [datetime] NULL,
	[Created] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NOT NULL,
	[Modified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentFile]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentFile](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[FileId] [uniqueidentifier] NULL,
	[Amount] [decimal](19, 5) NOT NULL,
	[SendPaymentOn] [datetime] NULL,
	[ConfirmedPaymentOn] [datetime] NULL,
	[IsConfirmed] [bit] NOT NULL,
	[Created] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NOT NULL,
	[Modified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Association]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Association](
	[id] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayConstraints]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayConstraints](
	[DoctorPaymentId] [bigint] NOT NULL,
	[PayConstraintId] [bigint] NOT NULL,
	[DoctorpaymentIndex] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorPaymentId] ASC,
	[DoctorpaymentIndex] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GuardPayment]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GuardPayment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](255) NOT NULL,
	[GuardId] [bigint] NOT NULL,
	[DoctorPaymentId] [bigint] NULL,
	[Amount] [decimal](19, 5) NULL,
	[Status] [int] NULL,
	[Created] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NOT NULL,
	[Modified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedegaXmlNode]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedegaXmlNode](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[MedegaFileId] [bigint] NOT NULL,
	[ReasonOfFailure] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[MEMBER_INAMI_NUMBER] [nvarchar](255) NULL,
	[MEMBER_LASTNAME] [nvarchar](255) NULL,
	[MEMBER_FIRSTNAME] [nvarchar](255) NULL,
	[MEMBER_BANK_ACCOUNT] [nvarchar](255) NULL,
	[MEMBER_BANK_ACCOUNT_OWNER] [nvarchar](255) NULL,
	[FEE_DATE] [datetime] NULL,
	[ASSOCIATION_ID] [int] NULL,
	[ASSOCIATION_NAME] [nvarchar](255) NULL,
	[GEOGRAPHIC_ENTITY_NAME] [nvarchar](255) NULL,
	[NIS_CODE] [nvarchar](255) NULL,
	[ZIP_CODE] [nvarchar](255) NULL,
	[MANAGER_LASTNAME] [nvarchar](255) NULL,
	[MANAGER_FIRSTNAME] [nvarchar](255) NULL,
	[MANAGER_INAMI_NUMBER] [nvarchar](255) NULL,
	[PERIOD_START_TIME] [datetime] NULL,
	[PERIOD_END_TIME] [datetime] NULL,
	[ProcessTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceRatesPerYear]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceRatesPerYear](
	[Metadata] [bigint] NOT NULL,
	[PriceRate] [decimal](19, 5) NOT NULL,
	[Year] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Metadata] ASC,
	[Year] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayableDuration]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayableDuration](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[DayType] [int] NOT NULL,
	[Metadata] [bigint] NULL,
	[PayableDurationIndex] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holidays]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holidays](
	[Metadata] [bigint] NOT NULL,
	[Holiday] [datetime] NOT NULL,
	[HolidayIndex] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Metadata] ASC,
	[HolidayIndex] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Holiday] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guard]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guard](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[MedegaXmlNode] [bigint] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[DayType] [int] NOT NULL,
	[PriceMinuteRate] [decimal](19, 5) NULL,
	[PayableMinutes] [int] NULL,
	[Inactive] [bit] NULL,
	[IsPayed] [bit] NULL,
	[IsOnHold] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorPayment]    Script Date: 09/30/2011 15:04:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorPayment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[RizivNumber] [nvarchar](11) NOT NULL,
	[AccountNumberValue] [nvarchar](16) NULL,
	[Amount] [decimal](19, 5) NULL,
	[Status] [int] NOT NULL,
	[Created] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](255) NOT NULL,
	[Modified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](255) NOT NULL,
	[PaymentFileId] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateMedegaFile]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateMedegaFile]
	(
	@FileName NVARCHAR(255),
	@FileStatus INT,
	@FileId BIGINT OUTPUT
	)
AS
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	
	INSERT INTO dbo.MedegaFile (FileName, ReceivedOn, Status) VALUES (@FileName, GetDate(), @FileStatus)
	SET @FileId = @@IDENTITY
	RETURN @@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMedegaFileStatus]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateMedegaFileStatus]
	(
	@FileId INT,
	@FileStatus INT
	)
AS
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED

	UPDATE dbo.MedegaFile
	SET Status = @FileStatus
	WHERE id = @FileId
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMedegaXmlNodeStatus]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMedegaXmlNodeStatus]    Script Date: 01/19/2010 14:23:03 ******/

CREATE PROCEDURE [dbo].[sp_UpdateMedegaXmlNodeStatus]
	(
	@NodeId INT,
	@ReasonOfFailure NVARCHAR(255),
	@NodeStatus INT
	)
AS
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED

	UPDATE dbo.MedegaXmlNode
	SET ReasonOfFailure = @ReasonOfFailure,
	    Status = @NodeStatus
	WHERE id = @NodeId

	IF @NodeStatus = 2
	BEGIN
		UPDATE F
		SET F.[Status] = 3
		FROM MedegaFile F WITH(NOLOCK)
		INNER JOIN MedegaXmlNode N WITH(NOLOCK) ON F.id = N.MedegaFileId
		WHERE N.id = @NodeId
	END

	IF @NodeStatus = 4
	BEGIN
		UPDATE F
		SET F.[Status] = 5
		FROM MedegaFile F WITH(NOLOCK)
		INNER JOIN MedegaXmlNode Node WITH(NOLOCK) ON F.id = Node.MedegaFileId
		WHERE Node.id = @NodeId AND F.Status = 2 AND NOT EXISTS (
			SELECT *
			FROM MedegaXmlNode N WITH(NOLOCK)
			WHERE N.MedegaFileId = F.id AND N.Status != 4
		)
	END
	
	RETURN 1
GO
/****** Object:  StoredProcedure [dbo].[sp_BTSDonePolling]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Peter Borremans
-- Create date: 19/01/2010
-- Description:	Procedure to poll for MedegaFile where the import is done, or don with errors
-- =============================================
CREATE PROCEDURE [dbo].[sp_BTSDonePolling]
AS
BEGIN
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

	DECLARE @ProcessTime datetime 
	SET @ProcessTime = getdate()

	UPDATE F
	SET F.ProcessTime = @ProcessTime
	FROM MedegaFile F
	WHERE F.Status IN (3,5) AND F.ProcessTime IS NULL

	SELECT F.id AS FileId, F.FileName, F.ReceivedOn, F.Status
	FROM MedegaFile F
	WHERE F.ProcessTime = @ProcessTime
	FOR XML AUTO, ELEMENTS

END
GO
/****** Object:  StoredProcedure [dbo].[sp_BTSCreateMedegaFile]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_BTSCreateMedegaFile]
	(
	@FileName NVARCHAR(255),
	@FileStatus INT	
	)
AS
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED

	DECLARE @FileId Int

	INSERT INTO dbo.MedegaFile (FileName, ReceivedOn, Status) VALUES (@FileName, GetDate(), @FileStatus)
	SET @FileId = @@IDENTITY
	
	SELECT 1 AS 'TAG', NULL AS 'PARENT', @FileId AS [FileId!1] FOR XML EXPLICIT
	
	RETURN @@ROWCOUNT
GO
/****** Object:  StoredProcedure [dbo].[sp_BTSCreateGuardPolling]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Peter Borremans
-- Create date: 12/01/2010
-- Description:	Stored Procedure for polling mechanism to call the MedegaImport webservice for each node
-- =============================================
CREATE PROCEDURE [dbo].[sp_BTSCreateGuardPolling]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED;

	DECLARE @ProcessTime datetime 
	SET @ProcessTime = getdate()

	UPDATE TOP (1000) N
	SET N.ProcessTime = @ProcessTime
	FROM MedegaXmlNode N
	INNER JOIN MedegaFile F ON N.MedegaFileID = F.id
	WHERE F.Status = 2 
		AND N.Status = 1
		AND N.ProcessTime IS NULL

    -- Insert statements for procedure here
	SELECT [Node].[MedegaFileID] as 'FileID', [Node].[id] as 'NodeId'
	FROM MedegaXmlNode Node WITH(NOLOCK)
	WHERE [Node].[ProcessTime] = @ProcessTime
	FOR XML AUTO



END
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateMedegaXmlNode]    Script Date: 09/30/2011 15:04:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateMedegaXmlNode] 
	(
	@FileId BIGINT,
	@Status INT,
	@MemberInamiNumber NVARCHAR(14),
	@MemberLastName NVARCHAR(48),
	@MemberFirstName NVARCHAR(12),
	@FeeDate DATETIME,
	@AssociationId INT,
	@AssociationName NVARCHAR(255),
	@GeographicEntityName NVARCHAR(255),
	@NisCode NVARCHAR(6),
	@ZipCode NVARCHAR(4),
	@ManagerLastName NVARCHAR(48),
	@ManagerFirstName NVARCHAR(12),
	@ManagerInamiNumber NVARCHAR(14),
	@PeriodStartTime DATETIME,
	@PeriodEndTime DATETIME,
	@NodeId BIGINT OUTPUT
	)
AS
	SET NOCOUNT ON
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	
	INSERT INTO dbo.MedegaXmlNode(MedegaFileId, 
	                              Status, 
	                              Member_Inami_Number,
	                              Member_LastName,
	                              Member_FirstName,
	                              Member_Bank_Account,
	                              Member_Bank_Account_Owner,
	                              Fee_Date,
	                              Association_Id,
	                              Association_Name,
	                              Geographic_Entity_Name,
	                              Nis_Code,
	                              Zip_Code,
	                              Manager_LastName,
	                              Manager_FirstName,
	                              Manager_Inami_Number,
	                              Period_Start_Time,
	                              Period_End_Time)
	VALUES
	(
	 @FileId,
	 @Status,
	 @MemberInamiNumber,
	 @MemberLastName,
	 @MemberFirstName,
	 null,
	 null,
	 @FeeDate,
	 @AssociationId,
	 @AssociationName,
	 @GeographicEntityName,
	 @NisCode,
	 @ZipCode,
	 @MemberLastName,
	 @MemberFirstName,
	 @MemberInamiNumber,
	 @PeriodStartTime,
 	 @PeriodEndTime
	)	                              
	                              
	SET @NodeId = @@IDENTITY
	RETURN @@ROWCOUNT
GO
/****** Object:  ForeignKey [FK70120607E71893A9]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[DoctorPayment]  WITH CHECK ADD  CONSTRAINT [FK70120607E71893A9] FOREIGN KEY([PaymentFileId])
REFERENCES [dbo].[PaymentFile] ([id])
GO
ALTER TABLE [dbo].[DoctorPayment] CHECK CONSTRAINT [FK70120607E71893A9]
GO
/****** Object:  ForeignKey [FKA13CAAD09CE2409F]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[Guard]  WITH CHECK ADD  CONSTRAINT [FKA13CAAD09CE2409F] FOREIGN KEY([MedegaXmlNode])
REFERENCES [dbo].[MedegaXmlNode] ([id])
GO
ALTER TABLE [dbo].[Guard] CHECK CONSTRAINT [FKA13CAAD09CE2409F]
GO
/****** Object:  ForeignKey [FK1955D586A22CBF21]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[GuardPayment]  WITH CHECK ADD  CONSTRAINT [FK1955D586A22CBF21] FOREIGN KEY([DoctorPaymentId])
REFERENCES [dbo].[DoctorPayment] ([id])
GO
ALTER TABLE [dbo].[GuardPayment] CHECK CONSTRAINT [FK1955D586A22CBF21]
GO
/****** Object:  ForeignKey [FK1955D586A7CEE92A]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[GuardPayment]  WITH CHECK ADD  CONSTRAINT [FK1955D586A7CEE92A] FOREIGN KEY([GuardId])
REFERENCES [dbo].[Guard] ([id])
GO
ALTER TABLE [dbo].[GuardPayment] CHECK CONSTRAINT [FK1955D586A7CEE92A]
GO
/****** Object:  ForeignKey [FK3B0D2959B20B46F5]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[Holidays]  WITH CHECK ADD  CONSTRAINT [FK3B0D2959B20B46F5] FOREIGN KEY([Metadata])
REFERENCES [dbo].[GuardMetadata] ([id])
GO
ALTER TABLE [dbo].[Holidays] CHECK CONSTRAINT [FK3B0D2959B20B46F5]
GO
/****** Object:  ForeignKey [FK9CE2409FF4757751]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[MedegaXmlNode]  WITH NOCHECK ADD  CONSTRAINT [FK9CE2409FF4757751] FOREIGN KEY([MedegaFileId])
REFERENCES [dbo].[MedegaFile] ([id])
GO
ALTER TABLE [dbo].[MedegaXmlNode] CHECK CONSTRAINT [FK9CE2409FF4757751]
GO
/****** Object:  ForeignKey [FK67886CD9B20B46F5]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[PayableDuration]  WITH CHECK ADD  CONSTRAINT [FK67886CD9B20B46F5] FOREIGN KEY([Metadata])
REFERENCES [dbo].[GuardMetadata] ([id])
GO
ALTER TABLE [dbo].[PayableDuration] CHECK CONSTRAINT [FK67886CD9B20B46F5]
GO
/****** Object:  ForeignKey [FK52DB205E866FCE20]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[PayConstraints]  WITH CHECK ADD  CONSTRAINT [FK52DB205E866FCE20] FOREIGN KEY([PayConstraintId])
REFERENCES [dbo].[PayConstraint] ([id])
GO
ALTER TABLE [dbo].[PayConstraints] CHECK CONSTRAINT [FK52DB205E866FCE20]
GO
/****** Object:  ForeignKey [FK52DB205EA22CBF21]    Script Date: 09/30/2011 15:04:39 ******/
ALTER TABLE [dbo].[PayConstraints]  WITH CHECK ADD  CONSTRAINT [FK52DB205EA22CBF21] FOREIGN KEY([DoctorPaymentId])
REFERENCES [dbo].[DoctorPayment] ([id])
GO
ALTER TABLE [dbo].[PayConstraints] CHECK CONSTRAINT [FK52DB205EA22CBF21]
GO
/****** Object:  ForeignKey [FK721E226AB20B46F5]    Script Date: 09/30/2011 15:04:40 ******/
ALTER TABLE [dbo].[PriceRatesPerYear]  WITH CHECK ADD  CONSTRAINT [FK721E226AB20B46F5] FOREIGN KEY([Metadata])
REFERENCES [dbo].[GuardMetadata] ([id])
GO
ALTER TABLE [dbo].[PriceRatesPerYear] CHECK CONSTRAINT [FK721E226AB20B46F5]
GO
