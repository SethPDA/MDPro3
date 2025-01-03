#spmemvfs
LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE := cspmemvfs

LOCAL_SRC_FILES := spmemvfs.c

LOCAL_C_INCLUDES := $(LOCAL_PATH)/../../sqlite3

include $(BUILD_STATIC_LIBRARY)