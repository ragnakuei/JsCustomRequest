﻿namespace JsCustomRequest.Models
{
    public class ResponseDto
    {
        public int?   ErrorCode { get; set; }
        public string Message   { get; set; }

        public object Data { get; set; }
    }
}