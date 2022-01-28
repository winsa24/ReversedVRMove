package com.example.permissionhelper;

import android.app.Activity;
import android.content.Context;

import android.Manifest;
import android.content.pm.PackageManager;

import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;

import androidx.core.content.ContextCompat;

public class PermissionHelper {
    private Context mContext;
    private Activity mActivity;

    public PermissionHelper(Context context) {
        mContext = context;
        mActivity = (Activity)context;
    }
    public boolean CheckForPermission(String permission) {
        // Only available with API Level 23+: return mContext.checkSelfPermission(permission) == PackageManager.PERMISSION_GRANTED;
        return  ContextCompat.checkSelfPermission(mContext, permission) == PackageManager.PERMISSION_GRANTED;
    }
    public void RequestPermission(String permission) {
        // Only available with API Level 23+: mActivity.requestPermissions(new String[]{permission},1024);
        ActivityCompat.requestPermissions(mActivity, new String[]{permission},1024);
    }
}