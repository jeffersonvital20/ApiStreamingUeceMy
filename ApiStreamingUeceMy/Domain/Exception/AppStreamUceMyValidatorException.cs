namespace ApiStreamingUeceMy.Domain.Execption;

[Serializable]
public class AppStreamUceMyValidatorException : Exception
{
    public AppStreamUceMyValidatorException(Dictionary<string, IEnumerable<string>> errors) : base("Invalid data")
        => Errors = errors;

    public Dictionary<string, IEnumerable<string>> Errors { get; }
}
