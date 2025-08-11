using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourNamespace.Models
{
    public enum LogRecordType
    {
        Create = 0,
        Update = 1,
        Delete = 2,
        SystemError = 3,
        SystemWarning = 4,
        SystemInfo = 5
    }

    public enum LogEntityType
    {
        EntityA = 0,
        EntityB = 1
    }

    public enum LogEventInfo
    {
        SuccessSubmitChanges = 0,
        AutoRegistryEmployee = 1,
        SendEmail = 2,
        AppParameterChange = 3,
        ClientConsulting = 4,
        ExternalEvent = 5
    }

    [Table("logs")]
    public class LogRecord
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("user")]
        public string User { get; set; }

        [Column("datetime")]
        public DateTime DateTime { get; set; }

        [Column("recordtype")]
        public LogRecordType RecordType { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

        [Column("logguid")]
        public Guid LogGuid { get; set; }

        [Column("logguidlinked")]
        public Guid? LogGuidLinked { get; set; }

        [Column("entity")]
        public LogEntityType Entity { get; set; }

        [Column("eventinfo")]
        public LogEventInfo EventInfo { get; set; }

        [Column("fieldname")]
        public string FieldName { get; set; }

        [Column("oldvalue")]
        public string OldValue { get; set; }

        [Column("newvalue")]
        public string NewValue { get; set; }
    }
}