﻿using System;
using System.Net.Http;

namespace HttpClientBuilder
{
    public interface IOptionsBuilder: IHandlerBuilder, IHttpHeaderBuilder, IClientBuilder
    {
        
    }

    public interface IHandlerBuilder : ICustomerHandler, IAcceptAllCerts
    {
        
    }

    public interface IAcceptAllCerts
    {
        IHeaderOrBuilder AcceptSelfSignedCerts();
    }

    public interface ICustomerHandler
    {
        IHeaderOrBuilder ConfigureHandler(Func<HttpClientHandler> handlerFunc);
    }

    
}