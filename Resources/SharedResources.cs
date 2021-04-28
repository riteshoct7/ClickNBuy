using Microsoft.Extensions.Localization;

namespace Resources
{
    public class SharedResources : IAppResource
    {
        #region Properties
        private IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructrors
        public SharedResources(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
        }
        #endregion

        #region Methods
        public string GetResource(string key)
        {
            return _localizer[key];
        } 
        #endregion
    }
}
