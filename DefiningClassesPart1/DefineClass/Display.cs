namespace DefineClass
{
    public class Display
    {
        private string size;        //fields
        private string colors;

        public Display()            //empty constructor
        {

        }
        public Display(string displaySize, string displayColors)  //constructor with all characteristics
        {
            this.size = displaySize;
            this.colors = displayColors;
        }

        public string Size          //propertys
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public string Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }
    }
}
