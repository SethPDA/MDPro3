#irrlicht
LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE := irrlicht

LOCAL_C_INCLUDES := $(LOCAL_PATH)/include
LOCAL_C_INCLUDES += $(LOCAL_PATH)/source/Irrlicht
LOCAL_C_INCLUDES += $(LOCAL_PATH)/source/Irrlicht/zlib

LOCAL_CPPFLAGS := -D_IRR_STATIC_LIB_
LOCAL_CPPFLAGS += -DNO_IRR_COMPILE_WITH_ZIP_ENCRYPTION_
LOCAL_CPPFLAGS += -DNO_IRR_COMPILE_WITH_BZIP2_
LOCAL_CPPFLAGS += -DNO__IRR_COMPILE_WITH_MOUNT_ARCHIVE_LOADER_
LOCAL_CPPFLAGS += -DNO__IRR_COMPILE_WITH_PAK_ARCHIVE_LOADER_
LOCAL_CPPFLAGS += -DNO__IRR_COMPILE_WITH_NPK_ARCHIVE_LOADER_
LOCAL_CPPFLAGS += -DNO__IRR_COMPILE_WITH_TAR_ARCHIVE_LOADER_
LOCAL_CPPFLAGS += -DNO__IRR_COMPILE_WITH_WAD_ARCHIVE_LOADER_

LOCAL_SRC_FILES := \
    source/Irrlicht/os.cpp \
    source/Irrlicht/zlib/adler32.c \
    source/Irrlicht/zlib/crc32.c \
    source/Irrlicht/zlib/inffast.c \
    source/Irrlicht/zlib/inflate.c \
    source/Irrlicht/zlib/inftrees.c \
    source/Irrlicht/zlib/zutil.c \
    source/Irrlicht/CAttributes.cpp \
    source/Irrlicht/CFileList.cpp \
    source/Irrlicht/CFileSystem.cpp \
    source/Irrlicht/CLimitReadFile.cpp \
    source/Irrlicht/CMemoryFile.cpp \
    source/Irrlicht/CReadFile.cpp \
    source/Irrlicht/CWriteFile.cpp \
    source/Irrlicht/CXMLReader.cpp \
    source/Irrlicht/CXMLWriter.cpp \
    source/Irrlicht/CZipReader.cpp

include $(BUILD_STATIC_LIBRARY)