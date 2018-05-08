CREATE TABLE IF NOT EXISTS `dns_record_mx_tls_evaluator_results` (
  `mx_record_id` bigint(20) unsigned NOT NULL,
  `test1_result` int(11) DEFAULT NULL,
  `test1_description` varchar(512) DEFAULT NULL,
  `test2_result` int(11) DEFAULT NULL,
  `test2_description` varchar(512) DEFAULT NULL,
  `test3_result` int(11) DEFAULT NULL,
  `test3_description` varchar(512) DEFAULT NULL,
  `test4_result` int(11) DEFAULT NULL,
  `test4_description` varchar(512) DEFAULT NULL,
  `test5_result` int(11) DEFAULT NULL,
  `test5_description` varchar(512) DEFAULT NULL,
  `test6_result` int(11) DEFAULT NULL,
  `test6_description` varchar(512) DEFAULT NULL,
  `test7_result` int(11) DEFAULT NULL,
  `test7_description` varchar(512) DEFAULT NULL,
  `test8_result` int(11) DEFAULT NULL,
  `test8_description` varchar(512) DEFAULT NULL,
  `test9_result` int(11) DEFAULT NULL,
  `test9_description` varchar(512) DEFAULT NULL,
  `test10_result` int(11) DEFAULT NULL,
  `test10_description` varchar(512) DEFAULT NULL,
  `test11_result` int(11) DEFAULT NULL,
  `test11_description` varchar(512) DEFAULT NULL,
  `test12_result` int(11) DEFAULT NULL,
  `test12_description` varchar(512) DEFAULT NULL,
  `test13_result` int(11) DEFAULT NULL,
  `test13_description` varchar(512) DEFAULT NULL,
  PRIMARY KEY (`mx_record_id`),
  UNIQUE KEY `mx_record_id` (`mx_record_id`),
  KEY `mx_record_id_idx` (`mx_record_id`),
  CONSTRAINT `dns_record_mx_tls_evaluator_results$mx_record_id0` FOREIGN KEY (`mx_record_id`) REFERENCES `dns_record_mx` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
