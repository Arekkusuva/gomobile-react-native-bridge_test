
#import "RNGoTest.h"
#import "Test/Test.h"

@implementation RNGoTest

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

RCT_EXPORT_METHOD(showMessage:(NSString *) message)
{
    TestShowMessage(message);
}

@end
  
