using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KashmirRoyalCityApp
{
    public partial class CustomerInfoControl : UserControl
    {
        public CustomerInfoControl()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Dock = DockStyle.Fill;
        }
        public string customerName
        {
            get { return tbCustomerName.Text == null ? "" : tbCustomerName.Text; }
        }

        public string customerFatherName
        {
            get { return tbCustomerFatherName.Text == null ? "" : tbCustomerFatherName.Text; }
        }

        public string customerCNIC
        {
            get { return tbCustomerCnic.Text == null ? "" : tbCustomerCnic.Text; }
        }

        public string customerProfession
        {
            get { return tbCustomerProfession.Text == null ? "" : tbCustomerProfession.Text; }
        }

        public string customerContactMobile
        {
            get { return tbCustomerContactMobile.Text == null ? "" : tbCustomerContactMobile.Text; }
        }

        public string customerContactHome
        {
            get { return tbCustomerContactHome.Text == null ? "" : tbCustomerContactHome.Text; }
        }

        public string customerContactWork
        {
            get { return tbCustomerContactWork.Text == null ? "" : tbCustomerContactWork.Text; }
        }

        public string customerEmail
        {
            get { return tbCustomerEmail.Text == null ? "" : tbCustomerEmail.Text; }
        }
        public string customerCurrentAddress
        {
            get { return tbCustomerCurrentAddress.Text == null ? "" : tbCustomerCurrentAddress.Text; }
        }
        public string customerPermanentAddress
        {
            get { return tbCustomerPermanentAddress.Text == null ? "" : tbCustomerPermanentAddress.Text; }
        }

        public string validateFields()
        {
            var validationMessageList = new List<string>();
            try
            {
                bool areAllFieldsValid = false;
                if (String.IsNullOrEmpty(tbCustomerName.Text))
                {
                    validationMessageList.Add(lblCustomerName.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerFatherName.Text))
                {
                    validationMessageList.Add(lblCustomerFatherName.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerCnic.Text))
                {
                    validationMessageList.Add(lblCustomerCNIC.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerProfession.Text))
                {
                    validationMessageList.Add(lblCustomerProfession.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerContactMobile.Text))
                {
                    validationMessageList.Add(lblCustomerContactMobile.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerContactHome.Text))
                {
                    validationMessageList.Add(lblCustomerContactHome.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerEmail.Text))
                {
                    validationMessageList.Add(lblCustomerEmail.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerCurrentAddress.Text))
                {
                    validationMessageList.Add(lblCustomerCurrentAddress.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (String.IsNullOrEmpty(tbCustomerPermanentAddress.Text))
                {
                    validationMessageList.Add(lblCustomerPermenantAddress.Text);
                    areAllFieldsValid = false;
                }
                else
                {
                    areAllFieldsValid = true;
                }
                if (areAllFieldsValid)
                {
                    return "";
                }
                else
                {
                    return string.Join("\n", validationMessageList);
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
