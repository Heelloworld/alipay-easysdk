// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;

using Alipay.EasySDK.Kernel;
using Alipay.EasySDK.Payment.Page.Models;

namespace Alipay.EasySDK.Payment.Page
{
    public class Client : BaseClient
    {

        public Client(Config config): base(config.ToMap())
        { }


        public AlipayTradePagePayResponse Pay(string subject, string outTradeNo, string totalAmount, string returnUrl)
        {
            Dictionary<string, string> systemParams = new Dictionary<string, string>()
            {
                {"method", "alipay.trade.page.pay"},
                {"app_id", _getConfig("appId")},
                {"timestamp", _getTimestamp()},
                {"format", "json"},
                {"version", "1.0"},
                {"alipay_sdk", _getSdkVersion()},
                {"charset", "UTF-8"},
                {"sign_type", _getConfig("signType")},
                {"app_cert_sn", _getMerchantCertSN()},
                {"alipay_root_cert_sn", _getAlipayRootCertSN()},
            };
            Dictionary<string, object> bizParams = new Dictionary<string, object>()
            {
                {"subject", subject},
                {"out_trade_no", outTradeNo},
                {"total_amount", totalAmount},
                {"product_code", "FAST_INSTANT_TRADE_PAY"},
            };
            Dictionary<string, string> textParams = new Dictionary<string, string>()
            {
                {"return_url", returnUrl},
            };
            string sign = _sign(systemParams, bizParams, textParams, _getConfig("merchantPrivateKey"));
            Dictionary<string, string> response = new Dictionary<string, string>()
            {
                {"body", _generatePage("POST", systemParams, bizParams, textParams, sign)},
            };
            return TeaModel.ToObject<AlipayTradePagePayResponse>(response);
        }

    }
}
