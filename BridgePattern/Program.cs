
using BridgePattern;

Subject subject;

subject = new TPR(new PassExamTalk());
subject.Pass();

subject = new ATiSRPO(new PassExamWrite());
subject.Pass();