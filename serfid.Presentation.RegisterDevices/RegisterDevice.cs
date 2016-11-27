using serfid.Interfaces.ValueObjects;
using serfid.MainModule;
using System;
using System.Windows.Forms;

namespace serfid.Presentation.RegisterDevices
{
    public partial class RegisterDevice : Form
    {
        private readonly Serfid _serfidApp;
        private static int _maxLenth = 300;

        public RegisterDevice()
        {
            InitializeComponent();
            _serfidApp = new Serfid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            tbUidTag.Clear();
            tbRating.Clear();
            tbPrice.Clear();
            tbDeviceName.Clear();
            tbDetails.Clear();
            tbImageUrl.Clear();
        }

        private void btnScanTag_Click(object sender, EventArgs e)
        {
            tbUidTag.Text = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 19);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InvalidInfo()) return;

            double price;
            int rating;

            double.TryParse(tbPrice.Text, out price);
            int.TryParse(tbRating.Text, out rating);

            DeviceInfo device = new DeviceInfo
            {
                Tag = tbUidTag.Text,
                Device = tbDeviceName.Text,
                Detail = tbDetails.Text,
                Price = price,
                Date = DateTime.Now,
                Rating = rating,
                ImageUrl = tbImageUrl.Text
            };

            bool success = _serfidApp.RegisterDevice(device);

            if (success)
            {
                ShowMsgSuccessRegisterDevice();
                ClearForm();
                return;
            }

            ShowMsgErrorRegisterDevice();
        }

        private bool InvalidInfo()
        {
            double price;
            int rating;
            bool incompleteInfo = tbUidTag.Text == string.Empty
                || tbRating.Text == string.Empty || tbRating.Text.Length >= _maxLenth
                || tbPrice.Text == string.Empty 
                || tbDeviceName.Text == string.Empty || tbDeviceName.Text.Length >= _maxLenth
                || tbDetails.Text == string.Empty || tbDetails.Text.Length >= _maxLenth
                || tbImageUrl.Text == string.Empty || tbImageUrl.Text.Length >= _maxLenth
                || double.TryParse(tbPrice.Text, out price) == false
                || int.TryParse(tbRating.Text, out rating) == false;

            if (incompleteInfo)
                ShowMsgIncompleteInfo();

            return incompleteInfo;
        }

        private void RegisterDevice_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serfidApp.Dispose();
        }

        private static void ShowMsgErrorRegisterDevice()
        {
            MessageBox.Show
                                ("It was not possible to save the information, please try again later or contact the system administrator."
                                , "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Error);
        }

        private static void ShowMsgSuccessRegisterDevice()
        {
            MessageBox.Show
                                ("Device register successfully"
                                , "Done"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Information);
        }

        private static void ShowMsgIncompleteInfo()
        {
            MessageBox.Show
                                ("Incomplete information\nPlease you must complete all fields"
                                , "Error"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Hand);
        }
    }
}
