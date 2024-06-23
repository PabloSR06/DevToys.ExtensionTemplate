using System.Web;
using Microsoft.Extensions.Logging;

namespace ExtensionTemplate.Helpers;

internal static partial class ExtensionTemplateHelper
{
    internal static string DoYourThing(string? data, ILogger logger, CancellationToken cancellationToken)
    {
        try
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }
            
            if (cancellationToken.IsCancellationRequested)
            {
                cancellationToken.ThrowIfCancellationRequested();
            }


            return data;
        }
        catch (OperationCanceledException)
        {
            logger.LogInformation("Operation was cancelled.");
            return "Operation cancelled.";
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error while doing your thing");
            return ex.Message;
        }
    }

}