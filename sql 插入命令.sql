 
SELECT * FROM Register;
SELECT * FROM Problems;
SELECT * FROM ProblemStatuses;
SELECT * FROM Contents;

INSERT ProblemStatuses VALUES(N'协助中',1);
INSERT ProblemStatuses VALUES(N'待协助',2);
INSERT ProblemStatuses VALUES(N'已酬谢',3);
INSERT ProblemStatuses VALUES(N'已撤销',4);

INSERT Contents VALUES(N'我有几个朋友是做快递的，去年12月份的工资老板拖着没发',N'浅梦年华','2019/2/23');
INSERT Contents VALUES(N'路上骑车走路 被汽车开门碰倒 这责任怎么负责的',N'那是风','2018/12/4');
INSERT Contents VALUES(N'发送前转换成base64，然后使用ajax的post发送',N'28zhu','2018/11/24');
INSERT Contents VALUES(N'详细：身份证正反面照，手持身份证照片泄漏到网上',N'wyy','2018/8/25');
INSERT Contents VALUES(N'我昨天晚上想出售百家号，结果遇到了骗子，账号被盗走，又被我拿回来了。',N'wyy','2018/8/23');
INSERT Contents VALUES(N'我给私人装修，讲的出工具的300每天，不出的270每天',N'陈百万','2018/8/13');


INSERT Problems VALUES(1,N'我给私人装修，讲的出工具的300每天，不出的270每天，','2019/2/23',1,0,20);
INSERT Problems VALUES(2,N' 路上骑车走路 被汽车开门碰倒','2018/12/4',0,0,30);
INSERT Problems VALUES(3,N'使用Ajax发送数据，Post方式，结果大小到服务端发生变化。','2018/11/24',0,1,50);
INSERT Problems VALUES(4,N'身份证隐私泄露问题','2018/8/25',0,0,15);
INSERT Problems VALUES(5,N' 我被骗子盯上了','2018/8/23',1,1,25);
INSERT Problems VALUES(6,N'律师官司、工伤劳务问题。','2018/8/13',1,0,35);

