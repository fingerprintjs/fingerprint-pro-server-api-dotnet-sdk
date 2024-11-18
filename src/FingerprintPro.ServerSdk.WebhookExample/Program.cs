using FingerprintPro.ServerSdk;

const string header = "v1=1b2c16b75bd2a870c114153ccda5bcfca63314bc722fa160d690de133ccbb9db";
const string secret = "secret";
var data = "data"u8.ToArray();

var isValid = WebhookValidation.IsValidSignature(header, data, secret);

Console.WriteLine(isValid ? "Webhook signature is correct!" : "Webhook signature is incorrect!");
