using source;

namespace ProjectsManagerTests
{
    [TestClass]
    public class Tests
    {
        private readonly RegistryControl registry = new RegistryControl();

        [TestMethod]
        public void LocalisationTest()
        {
            Localisation expected = new("Open", "Edit", "Delete", "Cancel", "Confirm", "Project name", "Project path", "Description", "Prog language", "This name already exists!", "Directory doesn't exists!", "Add project", "Requeired field!", "Settings", "Interface language"); 
            Localisation actual = new("English");

            Assert.AreEqual(expected.OpenButton, actual.OpenButton);
            Assert.AreEqual(expected.EditButton, actual.EditButton);
            Assert.AreEqual(expected.DeleteButton, actual.DeleteButton);
            Assert.AreEqual(expected.CancelButton, actual.CancelButton);
            Assert.AreEqual(expected.ConfirmButton, actual.ConfirmButton);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Path, actual.Path);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProgLanguage, actual.ProgLanguage);
            Assert.AreEqual(expected.AlreadyExistError, actual.AlreadyExistError);
            Assert.AreEqual(expected.DoesntExistError, actual.DoesntExistError);
            Assert.AreEqual(expected.AddProjectToolTip, actual.AddProjectToolTip);
            Assert.AreEqual(expected.RequiredFieldToolTip, actual.RequiredFieldToolTip);
            Assert.AreEqual(expected.Settings, expected.Settings);
            Assert.AreEqual(expected.Language, expected.Language);
        }


        [TestMethod]
        public void SetAndGetProjectInfoTest()
        {
            ProjectInfo projectInfo = new("TestName", "TestDescription", "TestPath", "TestGithub", "TestLang");

            registry.SetProjectInfo(projectInfo);

            ProjectInfo projectInfo1 = registry.GetProjectInfo(projectInfo.Name);

            Assert.AreEqual(projectInfo1.Name, projectInfo.Name);
            Assert.AreEqual(projectInfo1.Description, projectInfo.Description);
            Assert.AreEqual(projectInfo1.Path, projectInfo.Path);
            Assert.AreEqual(projectInfo1.GitHub, projectInfo.GitHub);
            Assert.AreEqual(projectInfo1.ProgLanguage, projectInfo.ProgLanguage);
        }

        [TestMethod]
        public void SetAndGetSettingsTest()
        {
            Settings settings = new Settings("English");

            registry.SetSettings(settings);

            Settings settings1 = registry.GetSettings();

            Assert.AreEqual(settings1.Language, settings.Language);
        }
    }
}