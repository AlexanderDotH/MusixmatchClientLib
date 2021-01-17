﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusixmatchClientLib.API.Model.Types
{
    enum StatusCode // All the descriptions were taken from the official Musixmatch API documentation
    {
        Success = 200, // The request was successful.
        BadSyntax = 400, // The request had bad syntax or was inherently impossible to be satisfied.
        AuthFailed = 401, // Authentication failed, probably because of invalid/missing API key.
        UsageLimitReached = 402, // The usage limit has been reached, either you exceeded per day requests limits or your balance is insufficient.
        NotAuthorized = 403, // You are not authorized to perform this operation.
        ResourceNotFound = 404, // The requested resource was not found.
        MethodNotFound = 405, // The requested method was not found.
        ServerError = 500, // Ops. Something were wrong.
        ServerBusy = 503 // Our system is a bit busy at the moment and your request can’t be satisfied.
    }
}