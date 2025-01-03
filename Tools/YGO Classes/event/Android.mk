#event
LOCAL_PATH := $(call my-dir)

include $(CLEAR_VARS)

LOCAL_MODULE := event
LOCAL_MODULE_FILENAME := libevent

LOCAL_C_INCLUDES := $(LOCAL_PATH)/.
LOCAL_C_INCLUDES += $(LOCAL_PATH)/include
LOCAL_C_INCLUDES += $(LOCAL_PATH)/compat
LOCAL_C_INCLUDES += $(LOCAL_PATH)/android

LOCAL_SRC_FILES := \
    event.c \
    buffer.c \
    bufferevent.c \
    bufferevent_sock.c \
    bufferevent_pair.c \
    listener.c \
    evmap.c \
    log.c \
    evutil.c \
    strlcpy.c \
    signal.c \
    bufferevent_filter.c \
    evthread.c \
    evthread_pthread.c \
    bufferevent_ratelim.c \
    evutil_rand.c \
    event_tagging.c \
    http.c \
    evdns.c \
    evrpc.c \
    epoll.c \
    poll.c \
    select.c \

include $(BUILD_STATIC_LIBRARY)