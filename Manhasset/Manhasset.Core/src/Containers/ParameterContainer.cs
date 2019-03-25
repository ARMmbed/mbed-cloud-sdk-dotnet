namespace Manhasset.Core.src.Containers
{
    public class ParameterContainer : BaseContainer
    {
        public bool Required { get; set; }
        public string ParamType { get; set; }
        public string Key { get; set; }
        public string DefaultValue { get; set; }
    }
}