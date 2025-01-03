#ygoserver
LOCAL_PATH := $(call my-dir)
LOCAL_PATH2 := $(LOCAL_PATH)

include $(LOCAL_PATH2)/lzma/Android.mk
include $(LOCAL_PATH2)/spmemvfs/Android.mk

include $(CLEAR_VARS)
LOCAL_PATH := $(LOCAL_PATH2)

LOCAL_MODULE    := ygoserver
LOCAL_MODULE_FILENAME := libygoserver

LOCAL_SRC_FILES := data_manager.cpp \
	deck_manager.cpp \
	game.cpp \
	gframe.cpp \
	netserver.cpp \
	replay.cpp \
	serverapi.cpp \
	single_duel.cpp \
	tag_duel.cpp	

LOCAL_C_INCLUDES := $(LOCAL_PATH)/spmemvfs $(LOCAL_PATH)/../ocgcore $(LOCAL_PATH)/../event/include $(LOCAL_PATH)/../event/android $(LOCAL_PATH)/../sqlite3 $(LOCAL_PATH)/../Irrlicht/source/Irrlicht $(LOCAL_PATH)/../Irrlicht/include

LOCAL_STATIC_LIBRARIES := clzma sqlite3 lua event irrlicht cspmemvfs
LOCAL_SHARED_LIBRARIES += ocgcore

LOCAL_CPPFLAGS := -DYGOPRO_SERVER_MODE
LOCAL_CPPFLAGS += -DSERVER_ZIP_SUPPORT
LOCAL_CPPFLAGS += -DSERVER_PRO2_SUPPORT
LOCAL_CPPFLAGS += -DSERVER_PRO3_SUPPORT
LOCAL_CPPFLAGS += -DSERVER_TAG_SURRENDER_CONFIRM

include $(BUILD_SHARED_LIBRARY)
