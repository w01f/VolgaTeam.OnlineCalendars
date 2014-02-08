DROP TABLE IF EXISTS `tbl_cache`;
CREATE TABLE IF NOT EXISTS `tbl_cache` (
  `id` char(128) NOT NULL,
  `expire` int(11) DEFAULT NULL,
  `value` longblob,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
