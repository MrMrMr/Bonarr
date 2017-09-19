using FluentValidation;
using NzbDrone.Common.Extensions;
using NzbDrone.Core.Annotations;
using NzbDrone.Core.ThingiProvider;
using NzbDrone.Core.Validation;
using System.Text.RegularExpressions;
using NzbDrone.Core.MetadataSource.RadarrAPI;

namespace NzbDrone.Core.NetImport.Bonarr
{

    public class RadarrSettingsValidator : AbstractValidator<RadarrSettings>
    {
        public RadarrSettingsValidator()
        {
            RuleFor(c => c.APIURL).ValidRootUrl();
        }
    }

    public class RadarrSettings : IProviderConfig
    {
        private static readonly RadarrSettingsValidator Validator = new RadarrSettingsValidator();

        public RadarrSettings()
        {
            APIURL = "https://api.radarr.video/v2";
            Path = "";
        }

        [FieldDefinition(0, Label = "Bonarr API URL", HelpText = "Link to to Bonarr API URL. Use https://staging.api.radarr.video if you are on nightly.")]
        public string APIURL { get; set; }

        [FieldDefinition(1, Label = "Path to list", HelpText = "Path to the list proxied by the Bonarr API. Check the wiki for available lists.")]
        public string Path { get; set; }

        public NzbDroneValidationResult Validate()
        {
            return new NzbDroneValidationResult(Validator.Validate(this));
        }
    }

}