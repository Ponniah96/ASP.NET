import Crypto from "crypto-js"
 
const encryptedApiKey="LW5NODVMPAVQUMHP9RBFZKE85";

export const apiKey = Crypto.AES.encrypt(encryptedApiKey,"secretKey");