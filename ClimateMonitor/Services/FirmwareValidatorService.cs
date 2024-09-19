using System.Text.RegularExpressions;

namespace ClimateMonitor.Services
{
    public class FirmwareValidatorService
    {
        private static readonly string ValidationRegex = @"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:-((?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+([0-9a-zA-Z-]+(?:\.[0-9azA-Z-]+)*))?$";
        
        public bool ValidateFirmware(string firmware)
        {
            Regex regex = new Regex(ValidationRegex);
            return regex.Match(firmware).Success;
        }
    }
}