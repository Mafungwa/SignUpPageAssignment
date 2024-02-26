
using Newtonsoft.Json;

namespace ProfileSln
{
    public partial class MainPage : ContentPage
    {
        private Student _currentStudent;

        public Student  CurrentStudent
        {
            get { return _currentStudent; }
            set { _currentStudent = value;

                OnPropertyChanged();
            
            }
        }

        public MainPage()
        {
            InitializeComponent();

            LoadData(); 
            BindingContext = this;
        }
        public void SaveData()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            string fullFileName = Path.Combine(filePath, "studentrecord.txt");
            string studentJson = JsonConvert.SerializeObject(CurrentStudent);
            File.WriteAllText(fullFileName, studentJson);
        }
        public void LoadData()
        {
 
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullFileName = Path.Combine(filePath, "studentrecord.txt");

            if (File.Exists(fullFileName))
            {

                string fileContent = File.ReadAllText(fullFileName);
                CurrentStudent = JsonConvert.DeserializeObject<Student>(fileContent);
            }

            else
            {
                CurrentStudent = new Student();
            }

        }
        private void Button_Clicked(object sender, EventArgs e)
        {            
            SaveData();
        }
    }

}
