using System;
using System.Windows.Input;

class SceneManager
{
	#region SINGLETON

	static SceneManager instance = null;

	static public void CraeteInstance()
	{
		if (instance == null)
		{
			instance = new SceneManager();
			instance.Init();
		}
	}

	static public SceneManager Get() { return instance; }

	SceneManager() { }

	#endregion SINGLETON

	Scene m_pNowScene = null;

	void Init()
	{
		ChangeScene(eScene.Main);
		AllManager.CraeteInstance(30);

		arValue[0] = eKey.Left;
		arValue[1] = eKey.Down;
		arValue[2] = eKey.Right;
		arValue[3] = eKey.Up;
		arValue[4] = eKey.Space;

		for (int i = 0; i < m_arStates.Length; ++i)
		{
			m_arStates[i] = eKeyState.Unpress;
		}
	}

	void ChangeScene(eScene a_eScene)
	{
		m_pNowScene = null;

		switch (a_eScene)
		{
			case eScene.Main:
				{
                    m_pNowScene = new MainScene();
                }
				break;
            case eScene.Select:
                {
                    m_pNowScene = new SelectScene();
                }
                break;
        }
	}

	public void Update(float a_fDelta)
	{
		m_pNowScene.Update(a_fDelta);
		InputCheck();

		UI.Render();
		UI.Score(AllManager.Get().m_nScore);                //점수 스코어
		UI.Life(AllManager.PLife);                          //플레이어 라이프 수
	}

	public void Render()
	{
		m_pNowScene.Render();
	}

	void InputCheck()
	{
		for (int i = 0; i < (int)eKey.Max; ++i)
		{
			if (Keyboard.GetKeyStates((Key)arValue[i]) == KeyStates.Down)
			{
				if (m_arStates[i] == eKeyState.Press)
				{
					m_arStates[i] = eKeyState.Down;
				}
				else
				{
					m_arStates[i] = eKeyState.Press;
				}
			}

			else
			{
				if (m_arStates[i] == eKeyState.Up)
				{
					m_arStates[i] = eKeyState.Unpress;
				}
				else
				{
					m_arStates[i] = eKeyState.Up;
				}
			}
		}
	}

	static eKeyState[] m_arStates = new eKeyState[(int)eKey.Max];
	static eKey[] arValue = new eKey[(int)eKey.Max];

	static int GetIndex(eKey a_eKey)
	{
		int nReturn = -1;
		for (int i = 0; i < arValue.Length; ++i)
		{
			if (arValue[i] == a_eKey)
			{
				nReturn = i;
				break;
			}
		}
		return nReturn;
	}

	public static eKeyState GetKeyState(eKey a_eKey)
	{
		return m_arStates[GetIndex(a_eKey)];
	}
}
