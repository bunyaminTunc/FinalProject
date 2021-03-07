using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string  MaintenanceTime="sistem bakımda";
        internal static string ProductListed="ürünler listelendi";
        internal static string ProductCountOfCategoryError = "bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "bu isimde zaten baska bir urun var ";
        internal static string CategoryLimitExceded = "kategori limiti asildigi icin yeni urun eklenemiyor";
        internal static string  AuthorizationDenied="yetkiniz yok.";
        internal static string UserRegistered = "kayıt olundu";
        internal static string UserNotFound = "kullanıcı bulnunamadi";
        internal static string PasswordError="sifre yanlis";
        internal static string SuccessfulLogin = "basarili giris";
        internal static string UserAlreadyExists = "kullanici mevcut";
        internal static string AccessTokenCreated = "token olusturuldu";
    }
}
