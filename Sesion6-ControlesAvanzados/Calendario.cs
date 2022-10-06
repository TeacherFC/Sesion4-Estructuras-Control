namespace Sesion6_ControlesAvanzados
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            //Configurar fecha minima y maxima del datetimepicker.
            this.dateTimePicker1.MinDate = new DateTime(2022,09,02);
            this.dateTimePicker1.MaxDate = new DateTime(2022,10,02);

            //Formato personalizado de fecha del datetimepicker
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            //Configurar fecha minima y maxima de month calendar
            monthCalendar1.MinDate = new DateTime(2022,02,01);
            monthCalendar1.MaxDate = new DateTime(2022,09,30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setear la fecha actual en los controles de fecha
            dateTimePicker1.Value = DateTime.Now;
            monthCalendar1.SetDate(DateTime.Now);
        }
    }
}