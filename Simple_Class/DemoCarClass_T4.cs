using System;

namespace Simple_Class
{
    public partial class DemoCarClass
    {

        ///<summary>Код машины</summary>
        public Guid CarGuid;


        ///<summary>Год постройки машины</summary>
        public int CarBuildYear {get; set;}


        private string _Model; 
        ///<summary>Модель</summary>
        public string Model 
        {
            get => _Model; 
            set
            {
                if(value == _Model) return;
                _Model = value;
                OnPropChanged("Model");
            }
        }


        public DemoCarClass() {}

        public DemoCarClass(DemoCarClass source)
        {
            this.CarGuid = source.CarGuid;
            this.CarBuildYear = source.CarBuildYear;
            this.Model = source.Model;
        }

    }
}