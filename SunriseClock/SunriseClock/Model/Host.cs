using PropertyChanged;

namespace SunriseClock.Model
{
    [ImplementPropertyChanged]
    public class Host
    {
        public string Name { get; set; }
        public int Port { get; set; }
    }
}
