import vrep
import array
from System import Array

def get_rgb_from_kinect(clientID):

    errorCodeKinectRGB, kinect_rgb = vrep.simxGetObjectHandle(clientID, 'kinect_rgb', vrep.simx_opmode_oneshot_wait)
    _, rgb_resolution, rgb_image_raw = vrep.simxGetVisionSensorImage(clientID, kinect_rgb, 0, vrep.simx_opmode_oneshot_wait)

    rgb_image = array.array('i', rgb_image_raw)

    return Array[int](rgb_image)
