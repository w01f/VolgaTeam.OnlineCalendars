DROP TABLE IF EXISTS `tbl_day`;
CREATE TABLE IF NOT EXISTS `tbl_day` (
  `id` varchar(36) NOT NULL,
  `id_calendar` varchar(36) NOT NULL,
  `date` datetime NOT NULL,
  `comment` varchar(256) NULL,
  PRIMARY KEY (`id`),
  KEY `id_calendar` (`id_calendar`),
  KEY `date` (`date`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1;