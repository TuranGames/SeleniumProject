using CoolSmFramework.CoolSeleniumFramework.Elements;
using CoolSmFramework.CoolSeleniumFramework.Utils;
using CoolSmFramework.ThirdTask.Models;
using CoolSmFramework.ThirdTask.Pages;
using CoolSmFramework.Utils;
using OpenQA.Selenium;

namespace CoolSmFramework.Page
{
    public class TablesPage : BasePage
    {
        private static int lastindex = 0;
        private readonly Button elemnets = new(By.XPath("(//div[@class='card mt-4 top-card'])[1]//div"), "Elements");
        private readonly Button webTables = new(By.XPath("(//ul[@class='menu-list'])[1]/child::li[4]"), "Web tables");
        private readonly Button addButton = new(By.Id("addNewRecordButton"), "Add Button");
        private readonly Button form = new(By.Id("userForm"), "Registration Form");
        private readonly TextBox firstName = new(By.Id("firstName"), "FirstName TextBox");
        private readonly TextBox lastName = new(By.Id("lastName"), "LastName TextBox");
        private readonly TextBox email = new(By.Id("userEmail"), "Email TextBox");
        private readonly TextBox age = new(By.Id("age"), "Age TextBox");
        private readonly TextBox salary = new(By.Id("salary"), "Salary TextBox");
        private readonly TextBox department = new(By.Id("department"), "Department TextBox");
        private readonly Button submit = new(By.Id("department"), "Submit Button");
        private readonly static Button languages = new(By.Id("languages"), "Langauges");
        private readonly static BaseElement[] UniqueElems = { languages };
        protected internal TablesPage() : base(UniqueElems)
        {
        }

        public void EnterData()
        {
            User userFromJson = JsonHandler.GetAll<User>()[0];
            firstName.ClearAndType(userFromJson.FirstName);
            lastName.ClearAndType(userFromJson.LastName);
            email.ClearAndType(userFromJson.Email);
            age.ClearAndType(userFromJson.Age.ToString());
            salary.ClearAndType(userFromJson.Salary.ToString());
            department.ClearAndType(userFromJson.Department);
            submit.Click();
            submit.ClickWithJs();
            submit.Submit();
            WaitFor.ElementsIsInvisible(submit.locator);
        }
        public User UserFromPage(IWebElement container)
        {
            var userFromPage = container.FindElement(By.XPath("./child::div")).FindElements(By.XPath("./child::div"));
            if (userFromPage[0].Text == " " && userFromPage[1].Text == " " && userFromPage[2].Text == " " && userFromPage[3].Text == " "
                && userFromPage[4].Text == " " && userFromPage[5].Text == " ") 
            {
                return null;
            }
            else
            {
                var firstName = userFromPage[0].Text;
                var lastName = userFromPage[1].Text;
                var age = Convert.ToInt32(userFromPage[2].Text);
                var email = userFromPage[3].Text;
                var salary = Convert.ToInt32(userFromPage[4].Text);
                var department = userFromPage[5].Text;
                return new(1, firstName, lastName, email, age, salary, department);
            }
        }

        public bool UserApeared()
        {
            var users = GetElement(By.XPath("(//div[@class='rt-tbody'])"));
            var sfs = users.FindElements(By.XPath("./child::div"));
            User userFromJson = JsonHandler.GetAll<User>()[0];
            int i = 0;
            foreach (var user in sfs)
            {
                i++;
                if(UserFromPage(user) != null)
                {
                    if (UserFromPage(user).IsEqualTo(userFromJson))
                    {
                        lastindex = i;
                        return true;
                    }
                }
                else
                {
                    return false;
                }  
            }
            return false;
        }

        public void DeleteUser()
        {
            GetElement(By.Id("delete-record-" + lastindex)).Click();
        }

        public void ClickElementsButton()
        {
            elemnets.Click();
        }

        public void ClickWebtablesButton()
        {
            webTables.ClickWithJs();
        }

        public void ClickAddButton()
        {
            addButton.Click();
        }

        public bool FormExists()
        {
            return form.Exists();
        }
    }
}