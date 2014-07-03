#include "mozilla/ModuleUtils.h"
#include "nsIClassInfoImpl.h"
#include "fb2epub-xpcom-impl.h"

#define Fb2EpubConverterCaller_CONTRACTID "@fb2epub.net/fb2epub/fb2epub;1"

NS_GENERIC_FACTORY_CONSTRUCTOR(CFb2EpubConverterCaller)


// The following line defines a kFb2EpubConverterCaller_CID_CID CID variable.
NS_DEFINE_NAMED_CID(Fb2EpubConverterCaller_CID);
 
static const mozilla::Module::CIDEntry kFb2EPubCIDs[] = {
     { &kFb2EpubConverterCaller_CID, false, NULL, CFb2EpubConverterCallerConstructor , mozilla::Module::ANY_PROCESS},
        { NULL }
};
 
static const mozilla::Module::ContractIDEntry kFb2EPubContracts[] = {
     { Fb2EpubConverterCaller_CONTRACTID, &kFb2EpubConverterCaller_CID, mozilla::Module::ANY_PROCESS },
     { NULL }
};
 
static const mozilla::Module kFb2EPubModule = {
     mozilla::Module::kVersion,
     kFb2EPubCIDs,
     kFb2EPubContracts,
     NULL /* or a category definition if you need it */
};
 
NSMODULE_DEFN(nsFb2EPubModule) = &kFb2EPubModule;
NS_IMPL_MOZILLA192_NSGETMODULE(&kFb2EPubModule);