
EXTRA_DIST =  Makefile

# Warning: This is an automatically generated file, do not edit!

srcdir=.
top_srcdir=..

include $(top_srcdir)/config.make

ifeq ($(CONFIG),DEBUG_X86)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;"
ASSEMBLY = bin/Debug/AlienMuseumGame.exe
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

ALIENMUSEUMGAME_EXE_MDB_SOURCE=bin/Debug/AlienMuseumGame.exe.mdb
ALIENMUSEUMGAME_EXE_MDB=$(BUILD_DIR)/AlienMuseumGame.exe.mdb
MONOGAME_FRAMEWORK_DLL_SOURCE=../../../../usr/lib/monogame/MonoGame.Framework.dll
MONOGAME_FRAMEWORK_DLL_MDB_SOURCE=../../../../usr/lib/monogame/MonoGame.Framework.dll.mdb
MONOGAME_FRAMEWORK_DLL_MDB=$(BUILD_DIR)/MonoGame.Framework.dll.mdb
LIDGREN_NETWORK_DLL_SOURCE=../../../../usr/lib/monogame/Lidgren.Network.dll
LIDGREN_NETWORK_DLL_MDB_SOURCE=../../../../usr/lib/monogame/Lidgren.Network.dll.mdb
LIDGREN_NETWORK_DLL_MDB=$(BUILD_DIR)/Lidgren.Network.dll.mdb

endif

ifeq ($(CONFIG),RELEASE_X86)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+
ASSEMBLY = bin/Release/AlienMuseumGame.exe
ASSEMBLY_MDB = 
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

ALIENMUSEUMGAME_EXE_MDB=
MONOGAME_FRAMEWORK_DLL_SOURCE=../../../../usr/lib/monogame/MonoGame.Framework.dll
MONOGAME_FRAMEWORK_DLL_MDB=
LIDGREN_NETWORK_DLL_SOURCE=../../../../usr/lib/monogame/Lidgren.Network.dll
LIDGREN_NETWORK_DLL_MDB=

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(ALIENMUSEUMGAME_EXE_MDB) \
	$(MONOGAME_FRAMEWORK_DLL) \
	$(MONOGAME_FRAMEWORK_DLL_MDB) \
	$(LIDGREN_NETWORK_DLL) \
	$(LIDGREN_NETWORK_DLL_MDB)  

BINARIES = \
	$(ALIENMUSEUMGAME)  


RESGEN=resgen2

MONOGAME_FRAMEWORK_DLL = $(BUILD_DIR)/MonoGame.Framework.dll
LIDGREN_NETWORK_DLL = $(BUILD_DIR)/Lidgren.Network.dll
ALIENMUSEUMGAME = $(BUILD_DIR)/alienmuseumgame

FILES =  \
	Game1.cs \
	Program.cs \
	Properties/AssemblyInfo.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	Icon.png \
	Content \
	alienmuseumgame.in 

REFERENCES =  \
	-pkg:monogame \
	-pkg:opentk \
	System \
	System.Core \
	System.Xml

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(BINARIES) 

#Targets
all: $(ASSEMBLY) $(PROGRAMFILES) $(BINARIES)  $(top_srcdir)/config.make

include $(top_srcdir)/Makefile.include
#include $(srcdir)/custom-hooks.make



$(eval $(call emit-deploy-target,MONOGAME_FRAMEWORK_DLL))
$(eval $(call emit-deploy-target,MONOGAME_FRAMEWORK_DLL_MDB))
$(eval $(call emit-deploy-target,LIDGREN_NETWORK_DLL))
$(eval $(call emit-deploy-target,LIDGREN_NETWORK_DLL_MDB))
$(eval $(call emit-deploy-wrapper,ALIENMUSEUMGAME,alienmuseumgame,x))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'


$(ASSEMBLY_MDB): $(ASSEMBLY)
$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	make pre-all-local-hook prefix=$(prefix)
	mkdir -p $(shell dirname $(ASSEMBLY))
	make $(CONFIG)_BeforeBuild
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
	make $(CONFIG)_AfterBuild
	make post-all-local-hook prefix=$(prefix)

install-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-install-local-hook prefix=$(prefix)
	make install-satellite-assemblies prefix=$(prefix)
	mkdir -p '$(DESTDIR)$(libdir)/$(PACKAGE)'
	$(call cp,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(ALIENMUSEUMGAME_EXE_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(MONOGAME_FRAMEWORK_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(MONOGAME_FRAMEWORK_DLL_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(LIDGREN_NETWORK_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(LIDGREN_NETWORK_DLL_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	mkdir -p '$(DESTDIR)$(bindir)'
	$(call cp,$(ALIENMUSEUMGAME),$(DESTDIR)$(bindir))
	make post-install-local-hook prefix=$(prefix)

uninstall-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-uninstall-local-hook prefix=$(prefix)
	make uninstall-satellite-assemblies prefix=$(prefix)
	$(call rm,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(ALIENMUSEUMGAME_EXE_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(MONOGAME_FRAMEWORK_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(MONOGAME_FRAMEWORK_DLL_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(LIDGREN_NETWORK_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(LIDGREN_NETWORK_DLL_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(ALIENMUSEUMGAME),$(DESTDIR)$(bindir))
	make post-uninstall-local-hook prefix=$(prefix)

install: install-local
uninstall: uninstall-local
clean: clean-local

include $(top_srcdir)/rules.make
