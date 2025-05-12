using MockTestCSE422.Assignment2;

INotification notification = new EmailNotification();
NotificationSender emailSender = new NotificationSender(notification);

emailSender.sendMessage("test mail");

INotification notification1 = new SmsNotification();
NotificationSender smsSender = new NotificationSender(notification1);

smsSender.sendMessage("test sms");

INotification notification2 = new PushNotification();
NotificationSender pushSender = new NotificationSender(notification2);

pushSender.sendMessage("test push");