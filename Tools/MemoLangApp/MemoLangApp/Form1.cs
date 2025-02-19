using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;



namespace MemoLangApp
{


    public partial class Form1 : Form
    {
        private string jsonFilePath = "..\\..\\..\\..\\..Repository\\"; // JSON 文件路径
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
        /// 监听单元格编辑完成事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveJsonData(); // 直接保存
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
                //openFileDialog.InitialDirectory = Application.StartupPath; // 指定初始路径
                openFileDialog.InitialDirectory = @"..\\..\\..\\..\\..Repository\\"; // 指定初始路径

                openFileDialog.Filter = "JSON 文件 (*.json)|*.json|所有文件 (*.*)|*.*";
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
            // 将AutoGenerateColumns属性设置为false
            //dataGridView1.AutoGenerateColumns = false;

            // 绑定数据源
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
                    MessageBox.Show("读取 JSON 失败：" + ex.Message);
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
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping // 让 JSON 直接输出 UTF-8
                });
                File.WriteAllText(jsonFilePath, json);
                //MessageBox.Show("数据已保存！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存 JSON 失败：" + ex.Message);
            }
        }
    }
}