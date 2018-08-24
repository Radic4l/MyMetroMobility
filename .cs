using System;

public class ConvertToJson
{
	public ConvertToJson()
	{
        List<Station> Stations = JsonConvert.DeserializeObject<List<Station>>(CallApi.ReceiveJson());

        foreach (Station OneStation in Stations)
        {
            Console.WriteLine(OneStation.Name);
            foreach (string Line in OneStation.Lines)
            {
                Console.WriteLine("\t" + Line);
            }
        }
    }
}
