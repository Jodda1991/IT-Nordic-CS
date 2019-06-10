DROP PROCEDURE IF EXISTS [dbo].[AddReminderItem]
GO
CREATE PROCEDURE [dbo].[AddReminderItem](
@contactId VARCHAR (50),
@targetDate DATETIMEOFFSET,
@message NVARCHAR (200),
@statusId TINYINT ,
@reminderId UNIQUEIDENTIFIER OUTPUT)
AS BEGIN
	SET NOCOUNT ON

	DECLARE
		@tempReminderItemId AS UNIQUEIDENTIFIER,
		@now AS DATETIMEOFFSET
	SELECT
		@tempReminderItemId = NEWID(),
		@now = SYSDATETIMEOFFSET()

INSERT INTO [dbo].[ReminderItem](
[Id],
[ContactId],
[TargetDate],
[Message],
[StatusId],
[CreatedDate],
[UpdatedDate])

VALUES(@tempReminderItemId,
@contactId,
@targetDate,
@message,
@statusId,
@now,
@now)

SET @reminderId = @tempReminderItemId
END
