﻿using AutoMapper;
using Collectively.Services.Operations.Domain;
using Collectively.Services.Operations.Dto;
using Collectively.Services.Operations.Queries;
using Collectively.Services.Operations.Services;

namespace Collectively.Services.Operations.Modules
{
    public class OperationModule : ModuleBase
    {
        public OperationModule(IOperationService operationService, IMapper mapper) 
            : base(mapper, "operations")
        {
            Get("{requestId}", args => Fetch<GetOperation, Operation>
                (async x => await operationService.GetAsync(x.RequestId))
                .MapTo<OperationDto>()
                .HandleAsync());
        }
    }
}