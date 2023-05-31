namespace MARShop.Infastructure.Share
{
    public class DConvertor
    {
        /// <summary>
        /// Convert lat long string to array with first element is lattitude and second element is longtitude
        /// </summary>
        /// <param name="latLong">String lat and long</param>
        /// <returns>[0] is lattitude, [1] is longtitude</returns>
        static public string[] LatLongToArray(string latLong)
        {
            return latLong.Split(',');
        }
    }
}
