@echo off
cd..
cd..
cd SqlMetal
SqlMetal /Pluralize /provider:SQLCompact /dbml:DataClasses1.dbml SINAVSORU.sdf /Password:123456
pause