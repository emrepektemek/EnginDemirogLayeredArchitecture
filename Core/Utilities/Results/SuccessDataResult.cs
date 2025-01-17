﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        public SuccessDataResult(T data):base(data,true)
        {
                
        }


        // default calitigin T'nin defaultudur ve default hali dondurulur. bu ve asagidaki cok fazla kullanilmaz fakat alt yapilarda alternatif olarak yazilabilir
        public SuccessDataResult(string message) : base(default,true, message)
        {

        }

        public SuccessDataResult():base(default,true)
        {
                
        }


    }
}
