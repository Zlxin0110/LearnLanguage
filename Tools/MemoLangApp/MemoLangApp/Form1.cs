using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;



namespace MemoLangApp
{


    public partial class Form1 : Form
    {
        private string jsonFilePath = "..\\..\\..\\..\\..Repository\\"; // JSON �ļ�·��
        private BindingSource bindingSource = new BindingSource();
        private List<DataRecord> records = new List<DataRecord>();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ������Ԫ��༭����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveJsonData(); // ֱ�ӱ���
        }

        /// <summary>
        /// select json file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = Application.StartupPath; // ָ����ʼ·��
                openFileDialog.InitialDirectory = @"..\\..\\..\\..\\..Repository\\"; // ָ����ʼ·��

                openFileDialog.Filter = "JSON �ļ� (*.json)|*.json|�����ļ� (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    jsonFilePath = openFileDialog.FileName;
                    textBox1.Text = jsonFilePath;

                    LoadJsonData();
                }
            }
        }

        /// <summary>
        /// Initialize DataGridView
        /// </summary>
        private void InitializeDataGridView()
        {
            // ��AutoGenerateColumns��������Ϊfalse
            //dataGridView1.AutoGenerateColumns = false;

            // ������Դ
            bindingSource.DataSource = records;
            dataGridView1.DataSource = bindingSource;

        }


        /// <summary>
        /// Load json data
        /// </summary>
        private void LoadJsonData()
        {
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    string json = File.ReadAllText(jsonFilePath);
                    records = JsonSerializer.Deserialize<List<DataRecord>>(json) ?? new List<DataRecord>();
                    bindingSource.DataSource = records;
                    bindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("��ȡ JSON ʧ�ܣ�" + ex.Message);
                }
            }
        }

        /// <summary>
        /// save json data
        /// </summary>
        private void SaveJsonData()
        {
            try
            {
                string json = JsonSerializer.Serialize(records, new JsonSerializerOptions {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping // �� JSON ֱ����� UTF-8
                });
                File.WriteAllText(jsonFilePath, json);
                //MessageBox.Show("�����ѱ��棡");
            }
            catch (Exception ex)
            {
                MessageBox.Show("���� JSON ʧ�ܣ�" + ex.Message);
            }
        }
    }
}