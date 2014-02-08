DROP TABLE IF EXISTS `tbl_calendar`;
CREATE TABLE IF NOT EXISTS `tbl_calendar` (
  `id` varchar(36) NOT NULL,
  `name` varchar(256) NOT NULL,
  `date_start` datetime NOT NULL,
  `date_end` datetime NOT NULL,
  `last_change_date` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1;