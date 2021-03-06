//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

#pragma once

using namespace Platform::Collections;
using namespace Windows::UI::Xaml::Controls::Primitives;

BEGIN_NAMESPACE_GAZE_INPUT

private ref class GazeFeedbackPopupFactory
{
private:

    Vector<Popup^>^ s_cache = ref new Vector<Popup^>();

public:

    Popup^ Get();

    void Return(Popup^ popup);
};

END_NAMESPACE_GAZE_INPUT
