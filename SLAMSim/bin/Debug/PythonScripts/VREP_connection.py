
import vrep

def Start_VREP():
    
    vrep.simxFinish(-1) 
    clientID=vrep.simxStart('127.0.0.1',19997,True,True,2000,5)
    if clientID ==-1:
        return -1
    else:
        vrep.simxStartSimulation(clientID,vrep.simx_opmode_blocking)
        return clientID

def Stop_VREP(clientID):
    
    vrep.simxStopSimulation(clientID,vrep.simx_opmode_blocking)
    vrep.simxFinish(clientID)


