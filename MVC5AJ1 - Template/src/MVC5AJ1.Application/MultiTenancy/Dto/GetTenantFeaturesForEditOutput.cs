using System.Collections.Generic;
using Abp.Application.Services.Dto;
using MVC5AJ1.Editions.Dto;

namespace MVC5AJ1.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}