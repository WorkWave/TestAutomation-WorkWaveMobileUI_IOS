using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.Workwave.Mobile.SharedData;

namespace WorkWave.Workwave.Mobile
{
    public class WorkwaveMobileUtility
    {
        public static void InitializeWorkwaveData(Table data, ref WorkwaveData WorkwaveData)
        {
            WorkwaveData.Login = data.CreateInstance<Login>();
            WorkwaveData.Order = data.CreateInstance<Order>();
            WorkwaveData.Attachment = data.CreateInstance<Attachment>();
            WorkwaveData.Note = data.CreateInstance<Note>();
            WorkwaveData.Services = data.CreateInstance<Payment>();
            WorkwaveData.Sketch = data.CreateInstance<Sketch>();
            WorkwaveData.Form = data.CreateInstance<Form>();
            WorkwaveData.TimeSheet = data.CreateInstance<TimeSheet>();

        }
    }
}
