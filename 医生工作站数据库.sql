	IF DB_ID('DoctorWorkstation') IS NOT NULL					
		DROP DATABASE DoctorWorkstation;				
	CREATE DATABASE DoctorWorkstation
		ON						
			(NAME='DataFile_1'					
			,FILENAME='D:\DoctorWorkstation\DataFile_1.mdf')					
		LOG ON						
			(NAME='LogFile_1'					
			,FILENAME='D:\DoctorWorkstation\LogFile_1.ldf');
USE DoctorWorkstation;
DROP TABLE IF EXISTS tb_Doctor
CREATE TABLE tb_Doctor
(No
              CHAR(10)
	   		NOT NULL								
		CONSTRAINT pk_Doctor_No								
			PRIMARY KEY(No)							
		CONSTRAINT ck_Doctor_No								
			CHECK(No LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
,
);