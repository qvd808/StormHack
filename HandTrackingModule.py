import cv2
import mediapipe as mp
import time

class handDetector():
    def __init__(self, mode = False, maxHand = 2, modelComplex = 1 , detectionCon = 0.5, trackCon = 0.5):
        self.mode = mode
        self.maxHand = maxHand
        self.modelComplex = modelComplex
        self.detectionCon = detectionCon
        self.trackCon = trackCon

        # create an object - to detect the hand
        self.mpHands = mp.solutions.hands
        self.hands = self.mpHands.Hands(
            self.mode, self.maxHand,self.modelComplex, self.detectionCon, self.trackCon)

        # method to draw point between points
        self.mpDraw = mp.solutions.drawing_utils

    def findHands(self, img, draw = True):
        imgRGB = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
        self.results = self.hands.process(imgRGB)
        if self.results.multi_hand_landmarks:
            for handLms in self.results.multi_hand_landmarks:
                if draw:
                    self.mpDraw.draw_landmarks(img, handLms, self.mpHands.HAND_CONNECTIONS)

        return img

    def findPosition(self, img, handNo = 0, draw = True):

        lmList = []
        if self.results.multi_hand_landmarks:
            myHand = self.results.multi_hand_landmarks[handNo]

            for id, landmark in enumerate(myHand.landmark):

                height, width, channel = img.shape
                cx, cy = int(landmark.x * width), int(landmark.y * height)

                lmList.append([id, cx, cy])
                if draw:
                    cv2.circle(img, (cx, cy), 9, (255, 0, 255), cv2.FILLED)

        return lmList

def main():

    # FPS
    previousTime = 0
    currentTime = 0

    #camera object
    cap = cv2.VideoCapture(0)
    detector = handDetector()

    while True:
        success, img = cap.read()
        img = detector.findHands(img)
        lmList = detector.findPosition(img)
        if len(lmList) != 0:
            print(lmList[4])

        #FPS calculate
        currentTime = time.time()
        fps = 1/(currentTime - previousTime)
        previousTime = currentTime


        #put FPS frame on the left-top corner
        cv2.putText(img, str(int(fps)), (10, 70),
                    cv2.FONT_HERSHEY_PLAIN, 3, (255, 0, 255), 3)
        cv2.imshow("Image", img)

        if cv2.waitKey(1) == ord('q'):
            break

    cap.release()
    cv2.destroyAllWindows()

if __name__ == "__main__":
    main()
