#lzma
LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE := clzma

LOCAL_SRC_FILES := Alloc.c \
	LzFind.c \
	LzmaDec.c \
	LzmaEnc.c \
	LzmaLib.c \


include $(BUILD_STATIC_LIBRARY)