using Direct.Shared;

namespace Template
{

    [DirectDom("NewType", "General")]
    public class NewType : DirectComponentBase
    {
        protected PropertyHolder<string> _Name = new PropertyHolder<string>("Name");


        [DirectDom("Name")]
        [DesignTimeInfo("Name")]
        public string Name
        {
            get { return _Name.TypedValue; }
            set { _Name.TypedValue = value; }
        }

        public NewType()
        {

        }

        public NewType(IProject project) : base(project)
        {

        }

    }

}
