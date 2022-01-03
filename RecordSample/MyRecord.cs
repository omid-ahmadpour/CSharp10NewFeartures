namespace RecordSample
{
    public class MyRecord
    {
        public static string MyFunction(MyRecordModel model)
        {
            return model.Name + " " + model.LastName;
        }
    }
}