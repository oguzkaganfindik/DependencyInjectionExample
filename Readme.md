Dependency Injection Example

Yazılım geliştirme süreçleri içerisinde en önemli kısımlardan birisi de yazılım tasarım sürecidir.
Kodun ilk yazımı sırasında yapılamayan tasarımın acısı genelde ilerleyen süreçlerde ürünler geliştikçe, yeni istekler geldikçe ortaya çıkmaktadır.
Yazılım tasarım prensiplerinden biri de, yazılım içerisinde bulunan komponentlerin gevşek bağlı olmasıdır.
Bu şekilde yapılan yazılım tasarımlarının, yapılar birbirine sıkı sıkıya bağlı olmadığından dolayı, gelebilecek yeni taleplerde, uygulamalar içerisinde yapılacak olan değişiklikler de minimuma inecektir.
Şimdi loglama ve mesaj gönderme ile ilgili bir örnek yapacağım. Bu örnekte önce hatalı yapılan yazılım kodlamasını, daha sonra Dependency Injection prensibine uygun olarak yapılmış olan doğru tasarımı ayrı ayrı uygulayacağım. 

* DBLogger'dan Mesajı yazıp, MailSender'dan mesajı gönderecek bir uygulama yaptık.
* Fakat daha sonra bize yapılan geri dönüş ile loglama için dosya sisteminin kullanmasını ve mesajı mail olarak göndermek değil, sms olarak gönderilmesini, uygulamanın buna göre değiştirilmesi istendi.
* İstenilen değişikliklere göre hatalı bir şekilde değiştirme yapıldı. Çünkü uygulamanın tasarımı hatalı yapılmıştı.
* İlerleyen zamanda başka bir kurum da dosya loglaması ve mail ile mesajlaşma istedi.
* Bu durumda yeniden commentleyip, yeniden build etmemiz gerekirdi. Bu doğru mu? Hayır. Tasarım böylesine hatalı yapılmamalıydı. 
* Burada yapılan hata, birtakım sınıflara sıkı sıkıya bağlı bir uygulama yapmamız durumudur. Bu sıkı sıkıya bağlı durum, uygulamamızın akışında radikal değişiklikler yapmadan değiştiremediğimiz sorununu ortaya çıkartmıştır. Bu durum uygulamanın genişletilebilir olmasını mümkün hale getirmemiştir.
* Oysa uygulamanın hem genişletilebilir olması gerekirdi hem de değişikliklerin olmaması gerekmekteydi.
** Bu noktada aklımıza gelmesi gereken, iyileştirmelerin interface üzerinden yapılması olmalıydı.
** Interfaces adlı bir klasör açıyoruz. Ardından, ConcretesHatasiz adlı bir klasör açıyoruz ve uygulamanın doğru tasarımını bu klasörlere yapıyoruz.
** Uygulamamızı bu şekilde tasarladığımızda artık uygulamamızı bütün yeni isteklere göre genişletme yapabiliriz ve artık herhangi bir kodu değiştirmemiz gerekmez.
** işte bu durum Solid Prensiplere uygun olandır.
