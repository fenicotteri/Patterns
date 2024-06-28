using ChainOfResponsibilityPattern;

Receiver receiver = new Receiver(true, false, true);

PaymentHandler bankPaymentHandler = new BankPaymentHandler();
PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();

bankPaymentHandler.AddHandler(paypalPaymentHandler);
bankPaymentHandler.AddHandler(moneyPaymentHadler);

bankPaymentHandler.Handle(receiver);