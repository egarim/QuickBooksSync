using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace BitFwks.Scheduler.BusinessObjects
{
    public class TypeToJobValueConverter : LocalizedClassInfoTypeConverter
    {
        protected override List<Type> GetTypesFromTypesInfo(ITypesInfo typesInfo)
        {
            List<Type> JobTypes = new List<Type>();
            //JobTypes.Add(typeof(Job1));
            //JobTypes.Add(typeof(Job2));
            //JobTypes.Add(typeof(Job3));
            //JobTypes.Add(typeof(JobBase));
            //JobTypes.Add(typeof(Job4));
            return JobTypes;
        }

        protected override string GetClassCaption(string fullName)
        {
            if (fullName.Contains("Job1"))
                return "Send email";

            if (fullName.Contains("Job2"))
                return "Process Accounting";

            if (fullName.Contains("Job3"))
                return "Process Inventory";

            if (fullName.Contains("JobBase"))
                return "Write File to desktop";

            if (fullName.Contains("Job4"))
                return "Demo Task";

            return base.GetClassCaption(fullName);
        }
    }
    [DefaultClassOptions()]
    [ModelDefault("IsCloneable", "true")]
    public class ScheduleBase : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public ScheduleBase(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.Monday = true;
            this.Tuesday = true;
            this.Wednesday = true;
            this.Thursday = true;
            this.Friday = true;
            //this.Saturday = true;
            //this.Sunday = true;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private bool manualExpression;
        private TimeZone timeZone;
        private bool monday;

        public bool Monday
        {
            get
            {
                return monday;
            }
            set
            {
                SetPropertyValue(nameof(Monday), ref monday, value);
            }
        }

        private bool tuesday;

        public bool Tuesday
        {
            get
            {
                return tuesday;
            }
            set
            {
                SetPropertyValue(nameof(Tuesday), ref tuesday, value);
            }
        }

        private bool wednesday;

        public bool Wednesday
        {
            get
            {
                return wednesday;
            }
            set
            {
                SetPropertyValue(nameof(Wednesday), ref wednesday, value);
            }
        }

        private bool thursday;

        public bool Thursday
        {
            get
            {
                return thursday;
            }
            set
            {
                SetPropertyValue(nameof(Thursday), ref thursday, value);
            }
        }

        private bool friday;

        public bool Friday
        {
            get
            {
                return friday;
            }
            set
            {
                SetPropertyValue(nameof(Friday), ref friday, value);
            }
        }

        private bool saturday;

        public bool Saturday
        {
            get
            {
                return saturday;
            }
            set
            {
                SetPropertyValue(nameof(Saturday), ref saturday, value);
            }
        }

        private bool sunday;

        public bool Sunday
        {
            get
            {
                return sunday;
            }
            set
            {
                SetPropertyValue(nameof(Sunday), ref sunday, value);
            }
        }

        private string expression;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Expression
        {
            get
            {
                return expression;
            }
            set
            {
                SetPropertyValue(nameof(Expression), ref expression, value);
            }
        }

        private int minute;

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                SetPropertyValue(nameof(Minute), ref minute, value);
            }
        }

        private int hour;

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                SetPropertyValue(nameof(Hour), ref hour, value);
            }
        }

        public bool ManualExpression
        {
            get => manualExpression;
            set => SetPropertyValue(nameof(ManualExpression), ref manualExpression, value);
        }

        protected override void OnSaving()
        {
            if (!ManualExpression)
            {
                BuildExpression();
            }

            base.OnSaving();
        }

        private void BuildExpression()
        {
            this.LastUpdate = DateTime.UtcNow.Ticks;
            StringBuilder Builder = new StringBuilder();
            Builder.Append("0");//Seconds
            Builder.Append(" ");
            Builder.Append(this.Minute);
            Builder.Append(" ");
            Builder.Append(this.Hour);
            Builder.Append(" ");
            Builder.Append("?");//Day of the month
            Builder.Append(" ");
            Builder.Append("*");//Month
            Builder.Append(" ");

            if (Monday)
            {
                Builder.Append("MON");
                Builder.Append(",");
            }
            if (Tuesday)
            {
                Builder.Append("TUE");
                Builder.Append(",");
            }
            if (Wednesday)
            {
                Builder.Append("WED");
                Builder.Append(",");
            }
            if (Thursday)
            {
                Builder.Append("THU");
                Builder.Append(",");
            }
            if (Friday)
            {
                Builder.Append("FRI");
                Builder.Append(",");
            }
            if (Saturday)
            {
                Builder.Append("SAT");
                Builder.Append(",");
            }
            if (Sunday)
            {
                Builder.Append("SUN");
                Builder.Append(",");
            }
            var BaseExpression = Builder.ToString().TrimEnd(',');
            BaseExpression = BaseExpression + " *";//Year
            this.Expression = BaseExpression;
        }

        public string GetDaysExpression()
        {
            StringBuilder Builder = new StringBuilder();
            if (Monday)
            {
                Builder.Append("MON");
                Builder.Append(",");
            }
            if (Tuesday)
            {
                Builder.Append("TUE");
                Builder.Append(",");
            }
            if (Wednesday)
            {
                Builder.Append("WED");
                Builder.Append(",");
            }
            if (Thursday)
            {
                Builder.Append("THU");
                Builder.Append(",");
            }
            if (Friday)
            {
                Builder.Append("FRI");
                Builder.Append(",");
            }
            if (Saturday)
            {
                Builder.Append("SAT");
                Builder.Append(",");
            }
            if (Sunday)
            {
                Builder.Append("SUN");
                Builder.Append(",");
            }
            return Builder.ToString().TrimEnd(',');
        }

        private System.DateTime startDate;

        public System.DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                SetPropertyValue(nameof(StartDate), ref startDate, value);
            }
        }

        private System.DateTime endDate;

        public System.DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                SetPropertyValue(nameof(EndDate), ref endDate, value);
            }
        }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
        }

        [ValueConverter(typeof(TypeToStringConverter))]
        [TypeConverter(typeof(TypeToJobValueConverter))]
        [Size(SizeAttribute.Unlimited)]
        public Type Job
        {
            get { return GetPropertyValue<Type>("Job"); }
            set { SetPropertyValue<Type>("Job", value); }
        }

        private long lastUpdate;

        [Browsable(false)]
        public long LastUpdate
        {
            get => lastUpdate;
            set => SetPropertyValue(nameof(LastUpdate), ref lastUpdate, value);
        }

        public TimeZone TimeZone
        {
            get => timeZone;
            set => SetPropertyValue(nameof(TimeZone), ref timeZone, value);
        }
    }
}